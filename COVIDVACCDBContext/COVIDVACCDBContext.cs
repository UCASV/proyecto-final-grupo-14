using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace COVIDVACCSYSTEM.COVIDVACCDBContext
{
    public partial class COVIDVACCDBContext : DbContext
    {
        public COVIDVACCDBContext()
        {
        }

        public COVIDVACCDBContext(DbContextOptions<COVIDVACCDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ailment> Ailments { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<CabinPhoneNumber> CabinPhoneNumbers { get; set; }
        public virtual DbSet<ChronicIllness> ChronicIllnesses { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<CitizenPhoneNumber> CitizenPhoneNumbers { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<Employeexprocess> Employeexprocesses { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<LoginInfo> LoginInfos { get; set; }
        public virtual DbSet<LoginRecord> LoginRecords { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Symptom> Symptoms { get; set; }
        public virtual DbSet<VaccinationAppointment> VaccinationAppointments { get; set; }
        public virtual DbSet<VaccinationProcess> VaccinationProcesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=EDWIN\\SQLEXPRESS;Database=COVIDVACCDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Ailment>(entity =>
            {
                entity.ToTable("AILMENTS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("citizen_id");

                entity.Property(e => e.IllnessId).HasColumnName("illness_id");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.Ailments)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AILMENTS__citize__59FA5E80");

                entity.HasOne(d => d.Illness)
                    .WithMany(p => p.Ailments)
                    .HasForeignKey(d => d.IllnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AILMENTS__illnes__5AEE82B9");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Cabins)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABIN__city_id__6383C8BA");
            });

            modelBuilder.Entity<CabinPhoneNumber>(entity =>
            {
                entity.ToTable("CABIN_PHONE_NUMBER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CabinId).HasColumnName("cabin_id");

                entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");

                entity.HasOne(d => d.Cabin)
                    .WithMany(p => p.CabinPhoneNumbers)
                    .HasForeignKey(d => d.CabinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABIN_PHO__cabin__628FA481");
            });

            modelBuilder.Entity<ChronicIllness>(entity =>
            {
                entity.ToTable("CHRONIC_ILLNESS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Illness)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("illness");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__D876F1BEC1DA0403");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.InstitutionId).HasColumnName("institution_id");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__city_id__5BE2A6F2");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.InstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__institu__5CD6CB2B");
            });

            modelBuilder.Entity<CitizenPhoneNumber>(entity =>
            {
                entity.ToTable("CITIZEN_PHONE_NUMBER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("citizen_id");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.CitizenPhoneNumbers)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN_P__citiz__5DCAEF64");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("CITY");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_name");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITY__state_id__6477ECF3");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("employee_type_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.InstitutionalMail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institutional_mail");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__city_i__5FB337D6");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__employ__5EBF139D");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EMPLOYEE_TYPE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeeType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_type");
            });

            modelBuilder.Entity<Employeexprocess>(entity =>
            {
                entity.ToTable("EMPLOYEEXPROCESS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.VaccProcessId).HasColumnName("vacc_process_id");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeexprocesses)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEEX__emplo__66603565");

                entity.HasOne(d => d.VaccProcess)
                    .WithMany(p => p.Employeexprocesses)
                    .HasForeignKey(d => d.VaccProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEEX__vacc___6754599E");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("INSTITUTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institution_name");
            });

            modelBuilder.Entity<LoginInfo>(entity =>
            {
                entity.ToTable("LOGIN_INFO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Userpassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userpassword");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LoginInfos)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOGIN_INF__emplo__656C112C");
            });

            modelBuilder.Entity<LoginRecord>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.CabinId })
                    .HasName("PK_cab_emp");

                entity.ToTable("LOGIN_RECORD");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.CabinId).HasColumnName("cabin_id");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("login_time");

                entity.HasOne(d => d.Cabin)
                    .WithMany(p => p.LoginRecords)
                    .HasForeignKey(d => d.CabinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_cab");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LoginRecords)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_emp");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("SIDE_EFFECTS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SymptomId).HasColumnName("symptom_id");

                entity.Property(e => e.SymptomTime).HasColumnName("symptom_time");

                entity.HasOne(d => d.Symptom)
                    .WithMany(p => p.SideEffects)
                    .HasForeignKey(d => d.SymptomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SIDE_EFFE__sympt__59063A47");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("STATE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state_name");
            });

            modelBuilder.Entity<Symptom>(entity =>
            {
                entity.ToTable("SYMPTOM");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Symptom1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("symptom");
            });

            modelBuilder.Entity<VaccinationAppointment>(entity =>
            {
                entity.ToTable("VACCINATION_APPOINTMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppDate)
                    .HasColumnType("date")
                    .HasColumnName("app_date");

                entity.Property(e => e.AppTime).HasColumnName("app_time");

                entity.Property(e => e.CabinId).HasColumnName("cabin_id");

                entity.Property(e => e.CitizenId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("citizen_id");

                entity.HasOne(d => d.Cabin)
                    .WithMany(p => p.VaccinationAppointments)
                    .HasForeignKey(d => d.CabinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__cabin__571DF1D5");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.VaccinationAppointments)
                    .HasForeignKey(d => d.CitizenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__citiz__5812160E");
            });

            modelBuilder.Entity<VaccinationProcess>(entity =>
            {
                entity.ToTable("VACCINATION_PROCESS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProcessDate)
                    .HasColumnType("date")
                    .HasColumnName("process_date");

                entity.Property(e => e.ProcessTime).HasColumnName("process_time");

                entity.Property(e => e.SideEffectsId).HasColumnName("side_effects_id");

                entity.Property(e => e.VaccinationAppId).HasColumnName("vacc_app_id");

                entity.Property(e => e.VaccinationTime).HasColumnName("vacc_time");

                entity.HasOne(d => d.SideEffects)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.SideEffectsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__side___68487DD7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}




