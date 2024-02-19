using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PerdePerakende.Models
{
    public partial class PerdePerakendeDBEntities : DbContext
    {
        public PerdePerakendeDBEntities() : base(GetConnectionString())
        {
            
            Database.SetInitializer(new CreateDatabaseIfNotExists<PerdePerakendeDBEntities>());
        }

        private static string GetConnectionString()
        {
            string ServerName = Environment.MachineName;
            Microsoft.Win32.RegistryView registryView = Environment.Is64BitOperatingSystem
                ? Microsoft.Win32.RegistryView.Registry64
                : Microsoft.Win32.RegistryView.Registry32;
            string server = "";

            try
            {
                using (Microsoft.Win32.RegistryKey hklm =
                    Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, registryView))
                {
                    Microsoft.Win32.RegistryKey instanceKey =
                        hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);

                    if (instanceKey != null)
                    {
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            if (instanceName == "MSSQLSERVER")
                            {
                                continue;
                            }
                            else
                            {
                                server = $"{ServerName}\\{instanceName}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            var connectionString =
                $"metadata=res://*/Models.PerdePerakendeModel.csdl|res://*/Models.PerdePerakendeModel.ssdl|res://*/Models.PerdePerakendeModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source={server};initial catalog=PerdePerakendeDB;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework\"";

            return connectionString;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<Perdeler> Perdeler { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
    }
}
