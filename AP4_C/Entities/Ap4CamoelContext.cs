using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace AP4_C.Entities;

public partial class Ap4CamoelContext : DbContext
{
    public Ap4CamoelContext()
    {
    }

    public Ap4CamoelContext(DbContextOptions<Ap4CamoelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Allergene> Allergenes { get; set; }

    public virtual DbSet<Cache> Caches { get; set; }

    public virtual DbSet<CacheLock> CacheLocks { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Commande> Commandes { get; set; }

    public virtual DbSet<Cuisinier> Cuisiniers { get; set; }

    public virtual DbSet<Dechet> Dechets { get; set; }

    public virtual DbSet<Employe> Employes { get; set; }

    public virtual DbSet<Etatplat> Etatplats { get; set; }

    public virtual DbSet<Facture> Factures { get; set; }

    public virtual DbSet<FailedJob> FailedJobs { get; set; }

    public virtual DbSet<Gere> Geres { get; set; }

    public virtual DbSet<InstancePlat> InstancePlats { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobBatch> JobBatches { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<MoyenPaiement> MoyenPaiements { get; set; }

    public virtual DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

    public virtual DbSet<PersonalAccessToken> PersonalAccessTokens { get; set; }

    public virtual DbSet<Personnel> Personnel { get; set; }

    public virtual DbSet<Plat> Plats { get; set; }

    public virtual DbSet<Platdujour> Platdujours { get; set; }

    public virtual DbSet<Reaprovision> Reaprovisions { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<Serveur> Serveurs { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<Tabler> Tablers { get; set; }

    public virtual DbSet<Typeplat> Typeplats { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.147.20;port=3306;user=admin;password=Camoel;database=AP4_Camoel", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.4.3-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Allergene>(entity =>
        {
            entity.HasKey(e => e.Idallergene).HasName("PRIMARY");

            entity.ToTable("allergene");

            entity.Property(e => e.Idallergene).HasColumnName("IDALLERGENE");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(500)
                .HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Libellealergene)
                .HasMaxLength(128)
                .HasColumnName("LIBELLEALERGENE");
        });

        modelBuilder.Entity<Cache>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PRIMARY");

            entity
                .ToTable("cache")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Expiration).HasColumnName("expiration");
            entity.Property(e => e.Value)
                .HasColumnType("mediumtext")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CacheLock>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PRIMARY");

            entity
                .ToTable("cache_locks")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Expiration).HasColumnName("expiration");
            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .HasColumnName("owner");
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.IdChat).HasName("PRIMARY");

            entity.ToTable("chat");

            entity.HasIndex(e => e.IdServeur, "idServeur");

            entity.Property(e => e.IdChat).HasColumnName("idChat");
            entity.Property(e => e.IdServeur).HasColumnName("idServeur");

            entity.HasOne(d => d.IdServeurNavigation).WithMany(p => p.Chats)
                .HasForeignKey(d => d.IdServeur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("chat_ibfk_1");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Idclient).HasName("PRIMARY");

            entity.ToTable("client");

            entity.Property(e => e.Idclient)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDCLIENT");

            entity.HasOne(d => d.IdclientNavigation).WithOne(p => p.Client)
                .HasForeignKey<Client>(d => d.Idclient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client_ibfk_1");
        });

        modelBuilder.Entity<Commande>(entity =>
        {
            entity.HasKey(e => e.Idcommande).HasName("PRIMARY");

            entity.ToTable("commande");

            entity.HasIndex(e => e.Idtable, "IDTABLE");

            entity.HasIndex(e => e.Idclient, "I_FK_COMMANDE_CLIENT");

            entity.HasIndex(e => e.Idreserv, "I_FK_COMMANDE_RESERVATION");

            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Commentaireclient)
                .HasMaxLength(128)
                .HasColumnName("COMMENTAIRECLIENT");
            entity.Property(e => e.Idclient).HasColumnName("IDCLIENT");
            entity.Property(e => e.Idreserv).HasColumnName("IDRESERV");
            entity.Property(e => e.Idtable).HasColumnName("IDTABLE");

            entity.HasOne(d => d.IdclientNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.Idclient)
                .HasConstraintName("commande_ibfk_4");

            entity.HasOne(d => d.IdreservNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.Idreserv)
                .HasConstraintName("commande_ibfk_2");

            entity.HasOne(d => d.IdtableNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.Idtable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("commande_ibfk_5");
        });

        modelBuilder.Entity<Cuisinier>(entity =>
        {
            entity.HasKey(e => e.Idper).HasName("PRIMARY");

            entity.ToTable("cuisinier");

            entity.Property(e => e.Idper)
                .ValueGeneratedNever()
                .HasColumnName("IDPER");

            entity.HasOne(d => d.IdperNavigation).WithOne(p => p.Cuisinier)
                .HasForeignKey<Cuisinier>(d => d.Idper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cuisinier_ibfk_1");
        });

        modelBuilder.Entity<Dechet>(entity =>
        {
            entity.HasKey(e => e.DateRecensement).HasName("PRIMARY");

            entity.ToTable("dechets");

            entity.Property(e => e.DateRecensement).HasColumnName("dateRecensement");
            entity.Property(e => e.Quantite)
                .HasPrecision(10, 2)
                .HasColumnName("quantite");
        });

        modelBuilder.Entity<Employe>(entity =>
        {
            entity.HasKey(e => e.Idper).HasName("PRIMARY");

            entity.ToTable("employe");

            entity.Property(e => e.Idper)
                .ValueGeneratedNever()
                .HasColumnName("IDPER");

            entity.HasOne(d => d.IdperNavigation).WithOne(p => p.Employe)
                .HasForeignKey<Employe>(d => d.Idper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("employe_ibfk_1");
        });

        modelBuilder.Entity<Etatplat>(entity =>
        {
            entity.HasKey(e => e.Idetat).HasName("PRIMARY");

            entity.ToTable("etatplat");

            entity.Property(e => e.Idetat).HasColumnName("IDETAT");
            entity.Property(e => e.Libelleetat)
                .HasMaxLength(128)
                .HasColumnName("LIBELLEETAT");
        });

        modelBuilder.Entity<Facture>(entity =>
        {
            entity.HasKey(e => new { e.Idfacture, e.Idcommande })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("facture");

            entity.HasIndex(e => e.Idcommande, "IDCOMMANDE");

            entity.HasIndex(e => e.Idmoyenpaiement, "I_FK_FACTURE_MOYEN_PAIEMENT");

            entity.Property(e => e.Idfacture)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDFACTURE");
            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Datefacture)
                .HasColumnType("datetime")
                .HasColumnName("DATEFACTURE");
            entity.Property(e => e.Idmoyenpaiement).HasColumnName("IDMOYENPAIEMENT");
            entity.Property(e => e.Tva).HasColumnName("TVA");

            entity.HasOne(d => d.IdcommandeNavigation).WithMany(p => p.Factures)
                .HasForeignKey(d => d.Idcommande)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("facture_ibfk_2");

            entity.HasOne(d => d.IdmoyenpaiementNavigation).WithMany(p => p.Factures)
                .HasForeignKey(d => d.Idmoyenpaiement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("facture_ibfk_1");
        });

        modelBuilder.Entity<FailedJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("failed_jobs")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Uuid, "failed_jobs_uuid_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Connection)
                .HasColumnType("text")
                .HasColumnName("connection");
            entity.Property(e => e.Exception).HasColumnName("exception");
            entity.Property(e => e.FailedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("failed_at");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.Queue)
                .HasColumnType("text")
                .HasColumnName("queue");
            entity.Property(e => e.Uuid).HasColumnName("uuid");
        });

        modelBuilder.Entity<Gere>(entity =>
        {
            entity.HasKey(e => new { e.Idper, e.Idtable, e.Ddmmyyyy })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("gere");

            entity.HasIndex(e => e.Ddmmyyyy, "I_FK_GERE_DATEGERER");

            entity.HasIndex(e => e.Idper, "I_FK_GERE_SERVEUR");

            entity.HasIndex(e => e.Idtable, "I_FK_GERE_TABLER");

            entity.Property(e => e.Idper).HasColumnName("IDPER");
            entity.Property(e => e.Idtable).HasColumnName("IDTABLE");
            entity.Property(e => e.Ddmmyyyy)
                .HasColumnType("datetime")
                .HasColumnName("DDMMYYYY");

            entity.HasOne(d => d.IdperNavigation).WithMany(p => p.Geres)
                .HasForeignKey(d => d.Idper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gere_ibfk_4");

            entity.HasOne(d => d.IdtableNavigation).WithMany(p => p.Geres)
                .HasForeignKey(d => d.Idtable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gere_ibfk_2");
        });

        modelBuilder.Entity<InstancePlat>(entity =>
        {
            entity.HasKey(e => new { e.Idcommande, e.Idinstance })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("instance_plat");

            entity.HasIndex(e => e.Idcommande, "I_FK_INSTANCE_PLAT_COMMANDE");

            entity.HasIndex(e => e.Idetat, "I_FK_INSTANCE_PLAT_ETATPLAT");

            entity.HasIndex(e => e.Idplat, "I_FK_INSTANCE_PLAT_PLAT");

            entity.Property(e => e.Idcommande).HasColumnName("IDCOMMANDE");
            entity.Property(e => e.Idinstance).HasColumnName("IDINSTANCE");
            entity.Property(e => e.Idetat)
                .HasDefaultValueSql("'1'")
                .HasColumnName("IDETAT");
            entity.Property(e => e.Idplat).HasColumnName("IDPLAT");

            entity.HasOne(d => d.IdcommandeNavigation).WithMany(p => p.InstancePlats)
                .HasForeignKey(d => d.Idcommande)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("instance_plat_ibfk_4");

            entity.HasOne(d => d.IdetatNavigation).WithMany(p => p.InstancePlats)
                .HasForeignKey(d => d.Idetat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("instance_plat_ibfk_3");

            entity.HasOne(d => d.IdplatNavigation).WithMany(p => p.InstancePlats)
                .HasForeignKey(d => d.Idplat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("instance_plat_ibfk_1");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("jobs")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Queue, "jobs_queue_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempts).HasColumnName("attempts");
            entity.Property(e => e.AvailableAt).HasColumnName("available_at");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.Queue).HasColumnName("queue");
            entity.Property(e => e.ReservedAt).HasColumnName("reserved_at");
        });

        modelBuilder.Entity<JobBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("job_batches")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CancelledAt).HasColumnName("cancelled_at");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FailedJobIds).HasColumnName("failed_job_ids");
            entity.Property(e => e.FailedJobs).HasColumnName("failed_jobs");
            entity.Property(e => e.FinishedAt).HasColumnName("finished_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Options)
                .HasColumnType("mediumtext")
                .HasColumnName("options");
            entity.Property(e => e.PendingJobs).HasColumnName("pending_jobs");
            entity.Property(e => e.TotalJobs).HasColumnName("total_jobs");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Idper).HasName("PRIMARY");

            entity.ToTable("manager");

            entity.Property(e => e.Idper)
                .ValueGeneratedNever()
                .HasColumnName("IDPER");
            entity.Property(e => e.Estadmin).HasColumnName("ESTADMIN");

            entity.HasOne(d => d.IdperNavigation).WithOne(p => p.Manager)
                .HasForeignKey<Manager>(d => d.Idper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("manager_ibfk_1");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.IdMessage).HasName("PRIMARY");

            entity.ToTable("messages");

            entity.HasIndex(e => e.IdChat, "idChat");

            entity.Property(e => e.IdMessage).HasColumnName("idMessage");
            entity.Property(e => e.BoolCuisinier).HasColumnName("boolCuisinier");
            entity.Property(e => e.Contenu)
                .HasMaxLength(255)
                .HasColumnName("contenu");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IdChat).HasColumnName("idChat");

            entity.HasOne(d => d.IdChatNavigation).WithMany(p => p.Messages)
                .HasForeignKey(d => d.IdChat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("messages_ibfk_1");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("migrations")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<MoyenPaiement>(entity =>
        {
            entity.HasKey(e => e.Idmoyenpaiement).HasName("PRIMARY");

            entity.ToTable("moyen_paiement");

            entity.Property(e => e.Idmoyenpaiement).HasColumnName("IDMOYENPAIEMENT");
            entity.Property(e => e.Libellemoyenpaiement)
                .HasMaxLength(128)
                .HasColumnName("LIBELLEMOYENPAIEMENT");
        });

        modelBuilder.Entity<PasswordResetToken>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PRIMARY");

            entity
                .ToTable("password_reset_tokens")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
        });

        modelBuilder.Entity<PersonalAccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("personal_access_tokens")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Token, "personal_access_tokens_token_unique").IsUnique();

            entity.HasIndex(e => new { e.TokenableType, e.TokenableId }, "personal_access_tokens_tokenable_type_tokenable_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abilities)
                .HasColumnType("text")
                .HasColumnName("abilities");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt)
                .HasColumnType("timestamp")
                .HasColumnName("expires_at");
            entity.Property(e => e.LastUsedAt)
                .HasColumnType("timestamp")
                .HasColumnName("last_used_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Token)
                .HasMaxLength(64)
                .HasColumnName("token");
            entity.Property(e => e.TokenableId).HasColumnName("tokenable_id");
            entity.Property(e => e.TokenableType).HasColumnName("tokenable_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Personnel>(entity =>
        {
            entity.HasKey(e => e.Idper).HasName("PRIMARY");

            entity.ToTable("personnel");

            entity.HasIndex(e => e.Idrestau, "I_FK_PERSONNEL_RESTAURANT");

            entity.Property(e => e.Idper)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDPER");
            entity.Property(e => e.Idrestau).HasColumnName("IDRESTAU");

            entity.HasOne(d => d.IdperNavigation).WithOne(p => p.Personnel)
                .HasForeignKey<Personnel>(d => d.Idper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_ibfk_2");

            entity.HasOne(d => d.IdrestauNavigation).WithMany(p => p.Personnel)
                .HasForeignKey(d => d.Idrestau)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_ibfk_1");
        });

        modelBuilder.Entity<Plat>(entity =>
        {
            entity.HasKey(e => e.Idplat).HasName("PRIMARY");

            entity.ToTable("plat");

            entity.HasIndex(e => e.Idrestau, "I_FK_PLAT_RESTAURANT");

            entity.HasIndex(e => e.Idtypeplat, "I_FK_PLAT_TYPEPLAT");

            entity.Property(e => e.Idplat).HasColumnName("IDPLAT");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Idrestau).HasColumnName("IDRESTAU");
            entity.Property(e => e.Idtypeplat).HasColumnName("IDTYPEPLAT");
            entity.Property(e => e.Libelleplat)
                .HasMaxLength(128)
                .HasColumnName("LIBELLEPLAT");
            entity.Property(e => e.Lienimg)
                .HasMaxLength(255)
                .HasColumnName("LIENIMG");
            entity.Property(e => e.Prixplatht)
                .HasColumnType("double(6,2)")
                .HasColumnName("PRIXPLATHT");
            entity.Property(e => e.Qte).HasColumnName("QTE");
            entity.Property(e => e.Veggie).HasColumnName("VEGGIE");

            entity.HasOne(d => d.IdrestauNavigation).WithMany(p => p.Plats)
                .HasForeignKey(d => d.Idrestau)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plat_ibfk_2");

            entity.HasOne(d => d.IdtypeplatNavigation).WithMany(p => p.Plats)
                .HasForeignKey(d => d.Idtypeplat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plat_ibfk_1");

            entity.HasMany(d => d.Idallergenes).WithMany(p => p.Idplats)
                .UsingEntity<Dictionary<string, object>>(
                    "PlatAllergene",
                    r => r.HasOne<Allergene>().WithMany()
                        .HasForeignKey("Idallergene")
                        .HasConstraintName("fk_plat_allergene_allergene"),
                    l => l.HasOne<Plat>().WithMany()
                        .HasForeignKey("Idplat")
                        .HasConstraintName("fk_plat_allergene_plat"),
                    j =>
                    {
                        j.HasKey("Idplat", "Idallergene")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("plat_allergene");
                        j.HasIndex(new[] { "Idallergene" }, "fk_plat_allergene_allergene");
                        j.IndexerProperty<int>("Idplat").HasColumnName("IDPLAT");
                        j.IndexerProperty<int>("Idallergene").HasColumnName("IDALLERGENE");
                    });
        });

        modelBuilder.Entity<Platdujour>(entity =>
        {
            entity.HasKey(e => new { e.Ddmmyyyy, e.Idplat })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("platdujour");

            entity.HasIndex(e => e.Ddmmyyyy, "I_FK_PLATDUJOUR_DATEPDJ");

            entity.HasIndex(e => e.Idper, "I_FK_PLATDUJOUR_PERSONNEL");

            entity.HasIndex(e => e.Idplat, "I_FK_PLATDUJOUR_PLAT");

            entity.Property(e => e.Ddmmyyyy)
                .HasColumnType("datetime")
                .HasColumnName("DDMMYYYY");
            entity.Property(e => e.Idplat).HasColumnName("IDPLAT");
            entity.Property(e => e.Idper).HasColumnName("IDPER");

            entity.HasOne(d => d.IdperNavigation).WithMany(p => p.Platdujours)
                .HasForeignKey(d => d.Idper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("platdujour_ibfk_3");

            entity.HasOne(d => d.IdplatNavigation).WithMany(p => p.Platdujours)
                .HasForeignKey(d => d.Idplat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("platdujour_ibfk_2");
        });

        modelBuilder.Entity<Reaprovision>(entity =>
        {
            entity.HasKey(e => new { e.Ddmmyyyy, e.Idplat })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("reaprovision");

            entity.HasIndex(e => e.Idplat, "IDPLAT");

            entity.HasIndex(e => e.Ddmmyyyy, "I_FK_REAPROVISIONNEMENT_DATER");

            entity.HasIndex(e => e.Idper, "I_FK_REAPROVISIONNEMENT_PERSONNEL");

            entity.Property(e => e.Ddmmyyyy)
                .HasColumnType("datetime")
                .HasColumnName("DDMMYYYY");
            entity.Property(e => e.Idplat).HasColumnName("IDPLAT");
            entity.Property(e => e.Idper).HasColumnName("IDPER");
            entity.Property(e => e.Qtereap).HasColumnName("QTEREAP");

            entity.HasOne(d => d.IdperNavigation).WithMany(p => p.Reaprovisions)
                .HasForeignKey(d => d.Idper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("reaprovision_ibfk_4");

            entity.HasOne(d => d.IdplatNavigation).WithMany(p => p.Reaprovisions)
                .HasForeignKey(d => d.Idplat)
                .HasConstraintName("reaprovision_ibfk_5");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Idreserv).HasName("PRIMARY");

            entity.ToTable("reservation");

            entity.HasIndex(e => e.Idclient, "I_FK_RESERVATION_CLIENT");

            entity.HasIndex(e => e.Idtable, "I_FK_RESERVATION_TABLER");

            entity.HasIndex(e => e.Qr, "UC_Person").IsUnique();

            entity.Property(e => e.Idreserv).HasColumnName("IDRESERV");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(255)
                .HasColumnName("COMMENTAIRE");
            entity.Property(e => e.Datedebut)
                .HasColumnType("datetime")
                .HasColumnName("DATEDEBUT");
            entity.Property(e => e.Datefin)
                .HasColumnType("datetime")
                .HasColumnName("DATEFIN");
            entity.Property(e => e.Idclient).HasColumnName("IDCLIENT");
            entity.Property(e => e.Idtable).HasColumnName("IDTABLE");
            entity.Property(e => e.Nbpers).HasColumnName("NBPERS");
            entity.Property(e => e.Qr).HasColumnName("QR");

            entity.HasOne(d => d.IdtableNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.Idtable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("reservation_ibfk_2");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.Idrestau).HasName("PRIMARY");

            entity.ToTable("restaurant");

            entity.Property(e => e.Idrestau).HasColumnName("IDRESTAU");
            entity.Property(e => e.Adrrestau)
                .HasMaxLength(128)
                .HasColumnName("ADRRESTAU");
            entity.Property(e => e.Logoimg)
                .HasMaxLength(128)
                .HasColumnName("LOGOIMG");
            entity.Property(e => e.Nomrestau)
                .HasMaxLength(128)
                .HasColumnName("NOMRESTAU");
        });

        modelBuilder.Entity<Serveur>(entity =>
        {
            entity.HasKey(e => e.Idper).HasName("PRIMARY");

            entity.ToTable("serveur");

            entity.Property(e => e.Idper)
                .ValueGeneratedNever()
                .HasColumnName("IDPER");

            entity.HasOne(d => d.IdperNavigation).WithOne(p => p.Serveur)
                .HasForeignKey<Serveur>(d => d.Idper)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("serveur_ibfk_1");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sessions")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.LastActivity, "sessions_last_activity_index");

            entity.HasIndex(e => e.UserId, "sessions_user_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasColumnName("ip_address");
            entity.Property(e => e.LastActivity).HasColumnName("last_activity");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.UserAgent)
                .HasColumnType("text")
                .HasColumnName("user_agent");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Tabler>(entity =>
        {
            entity.HasKey(e => e.Idtable).HasName("PRIMARY");

            entity.ToTable("tabler");

            entity.HasIndex(e => e.Idrestau, "I_FK_TABLER_RESTAURANT");

            entity.Property(e => e.Idtable).HasColumnName("IDTABLE");
            entity.Property(e => e.Estdispo).HasColumnName("ESTDISPO");
            entity.Property(e => e.Idrestau).HasColumnName("IDRESTAU");
            entity.Property(e => e.Nbpersmax).HasColumnName("NBPERSMAX");

            entity.HasOne(d => d.IdrestauNavigation).WithMany(p => p.Tablers)
                .HasForeignKey(d => d.Idrestau)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tabler_ibfk_1");
        });

        modelBuilder.Entity<Typeplat>(entity =>
        {
            entity.HasKey(e => e.Idtypeplat).HasName("PRIMARY");

            entity.ToTable("typeplat");

            entity.Property(e => e.Idtypeplat)
                .ValueGeneratedNever()
                .HasColumnName("IDTYPEPLAT");
            entity.Property(e => e.Typeplat1)
                .HasMaxLength(128)
                .HasColumnName("TYPEPLAT");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("users")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Email, "users_email_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.EmailVerifiedAt)
                .HasColumnType("timestamp")
                .HasColumnName("email_verified_at");
            entity.Property(e => e.Mdp)
                .HasMaxLength(255)
                .HasColumnName("mdp");
            entity.Property(e => e.MdpTemp)
                .HasMaxLength(255)
                .HasColumnName("mdpTemp");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .HasColumnName("prenom");
            entity.Property(e => e.RememberToken)
                .HasMaxLength(100)
                .HasColumnName("remember_token");
            entity.Property(e => e.Tel)
                .HasMaxLength(14)
                .HasColumnName("tel");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
