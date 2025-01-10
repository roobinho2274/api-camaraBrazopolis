using CamaraBrazopolisAPI.Models;

using Microsoft.EntityFrameworkCore;

namespace CamaraBrazopolisAPI.Data;

public partial class ApplicationDbContext : DbContext
{
    /*
     * Comando para atualizar os modelos
     * Scaffold-DbContext "SuaConnectionString" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
     */
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Requerimentos> Requerimentos
    {
        get; set;
    }

    public virtual DbSet<__EFMigrationsHistory> __EFMigrationsHistory
    {
        get; set;
    }

    public virtual DbSet<cargos> cargos
    {
        get; set;
    }

    public virtual DbSet<comissao_camara> comissao_camara
    {
        get; set;
    }

    public virtual DbSet<comissoes> comissoes
    {
        get; set;
    }

    public virtual DbSet<decretos> decretos
    {
        get; set;
    }

    public virtual DbSet<entidade> entidade
    {
        get; set;
    }

    public virtual DbSet<indicacoes> indicacoes
    {
        get; set;
    }

    public virtual DbSet<leis> leis
    {
        get; set;
    }

    public virtual DbSet<licitacao> licitacao
    {
        get; set;
    }

    public virtual DbSet<mesa_diretora> mesa_diretora
    {
        get; set;
    }

    public virtual DbSet<modalidade> modalidade
    {
        get; set;
    }

    public virtual DbSet<noticias> noticias
    {
        get; set;
    }

    public virtual DbSet<partidos> partidos
    {
        get; set;
    }

    public virtual DbSet<partidovereador> partidovereador
    {
        get; set;
    }

    public virtual DbSet<pedidos> pedidos
    {
        get; set;
    }

    public virtual DbSet<projeto_executivo> projeto_executivo
    {
        get; set;
    }

    public virtual DbSet<projeto_legislativo> projeto_legislativo
    {
        get; set;
    }

    public virtual DbSet<resolucoes> resolucoes
    {
        get; set;
    }

    public virtual DbSet<sessao_categoria> sessao_categoria
    {
        get; set;
    }

    public virtual DbSet<sessoes> sessoes
    {
        get; set;
    }

    public virtual DbSet<status_projetos> status_projetos
    {
        get; set;
    }

    public virtual DbSet<usuario> usuario
    {
        get; set;
    }

    public virtual DbSet<vereador_indicacao> vereador_indicacao
    {
        get; set;
    }

    public virtual DbSet<vereador_pedido> vereador_pedido
    {
        get; set;
    }

    public virtual DbSet<vereador_requerimento> vereador_requerimento
    {
        get; set;
    }

    public virtual DbSet<vereadores> vereadores
    {
        get; set;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=camarabraz3.mysql.dbaas.com.br;database=camarabraz3;user id=camarabraz3;password=Casy@130806", ServerVersion.Parse("5.7.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Requerimentos>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.arquivo).HasMaxLength(255);
            entity.Property(e => e.data_postagem)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.nome).HasMaxLength(255);
            entity.Property(e => e.resposta).HasMaxLength(255);
        });

        modelBuilder.Entity<__EFMigrationsHistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<cargos>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.nome).HasMaxLength(255);
        });

        modelBuilder.Entity<comissao_camara>(entity =>
        {
            entity
                .HasNoKey()
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.id_cargo).HasColumnType("int(11)");
            entity.Property(e => e.id_comissao).HasColumnType("int(11)");
            entity.Property(e => e.id_vereador).HasColumnType("int(11)");
        });

        modelBuilder.Entity<comissoes>(entity =>
        {
            entity
                .HasNoKey()
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.nome).HasMaxLength(255);
        });

        modelBuilder.Entity<decretos>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            entity.HasIndex(e => e.status, "status");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.arquivo).HasMaxLength(255);
            entity.Property(e => e.numero).HasMaxLength(50);
            entity.Property(e => e.status).HasColumnType("int(11)");

            entity.HasOne(d => d.statusNavigation).WithMany(p => p.decretos)
                .HasForeignKey(d => d.status)
                .HasConstraintName("decretos_ibfk_1");
        });

        modelBuilder.Entity<entidade>(entity =>
        {
            entity
                .HasNoKey()
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.nome).HasMaxLength(255);
        });

        modelBuilder.Entity<indicacoes>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.id, "id");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.arquivo).HasMaxLength(255);
            entity.Property(e => e.data_postagem)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.nome).HasMaxLength(255);
            entity.Property(e => e.resposta).HasMaxLength(20);
        });

        modelBuilder.Entity<leis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Caput).HasMaxLength(500);
            entity.Property(e => e.Arquivo).HasMaxLength(50);
            entity.Property(e => e.Numero).HasMaxLength(50);
        });

        modelBuilder.Entity<licitacao>(entity =>
        {
            entity
                .HasNoKey()
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Descricao).HasMaxLength(255);
            entity.Property(e => e.arquivo).HasMaxLength(55);
            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.nome).HasMaxLength(255);
            entity.Property(e => e.numero).HasColumnType("int(11)");
        });

        modelBuilder.Entity<mesa_diretora>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.cargo, "cargo");

            entity.HasIndex(e => e.id_vereador, "id_vereador");

            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.cargo).HasColumnType("int(11)");
            entity.Property(e => e.id_vereador).HasColumnType("int(11)");

            entity.HasOne(d => d.cargoNavigation).WithMany(p => p.mesa_diretora)
                .HasForeignKey(d => d.cargo)
                .HasConstraintName("mesa_diretora_ibfk_1");

            entity.HasOne(d => d.id_vereadorNavigation).WithMany(p => p.mesa_diretora)
                .HasForeignKey(d => d.id_vereador)
                .HasConstraintName("mesa_diretora_ibfk_2");
        });

        modelBuilder.Entity<modalidade>(entity =>
        {
            entity
                .HasNoKey()
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.nome).HasMaxLength(255);
        });

        modelBuilder.Entity<noticias>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            entity.Property(e => e.id).HasColumnType("int(10)");
            entity.Property(e => e.data).HasDefaultValueSql("'0000-00-00'");
            entity.Property(e => e.descricao).HasMaxLength(255);
            entity.Property(e => e.foto).HasMaxLength(255);
            entity.Property(e => e.titulo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.url_facebook).HasMaxLength(255);
        });

        modelBuilder.Entity<Models.partidos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Imagem).HasMaxLength(255);
            entity.Property(e => e.Nome).HasMaxLength(255);
        });

        modelBuilder.Entity<partidovereador>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("partidovereador");

            entity.Property(e => e.ativo).HasColumnType("int(11)");
            entity.Property(e => e.biografia)
                .UseCollation("latin1_general_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.email)
                .HasMaxLength(255)
                .UseCollation("latin1_general_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.foto)
                .HasMaxLength(255)
                .UseCollation("latin1_general_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.idPartido).HasColumnType("int(11)");
            entity.Property(e => e.imagem)
                .HasMaxLength(255)
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.nome)
                .HasMaxLength(255)
                .UseCollation("latin1_general_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.partido).HasColumnType("int(11)");
            entity.Property(e => e.partidoNome)
                .HasMaxLength(255)
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
        });

        modelBuilder.Entity<pedidos>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.arquivo).HasMaxLength(255);
            entity.Property(e => e.data_postagem)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.nome).HasMaxLength(255);
            entity.Property(e => e.resposta).HasMaxLength(255);
        });

        modelBuilder.Entity<projeto_executivo>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.status, "fk_status");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.arquivo).HasMaxLength(255);
            entity.Property(e => e.numero).HasMaxLength(255);
            entity.Property(e => e.status).HasColumnType("int(11)");

            entity.HasOne(d => d.statusNavigation).WithMany(p => p.projeto_executivo)
                .HasForeignKey(d => d.status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_status");
        });

        modelBuilder.Entity<projeto_legislativo>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.arquivo).HasMaxLength(255);
            entity.Property(e => e.numero).HasMaxLength(255);
            entity.Property(e => e.status).HasColumnType("int(11)");
        });

        modelBuilder.Entity<resolucoes>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            entity.HasIndex(e => e.status, "status");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.arquivo).HasMaxLength(255);
            entity.Property(e => e.numero).HasMaxLength(50);
            entity.Property(e => e.status).HasColumnType("int(11)");

            entity.HasOne(d => d.statusNavigation).WithMany(p => p.resolucoes)
                .HasForeignKey(d => d.status)
                .HasConstraintName("resolucoes_ibfk_1");
        });

        modelBuilder.Entity<sessao_categoria>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.nome).HasMaxLength(255);
        });

        modelBuilder.Entity<sessoes>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.categoria, "fk_categoria");

            entity.Property(e => e.id).HasColumnType("int(255)");
            entity.Property(e => e.Link).HasMaxLength(300);
            entity.Property(e => e.arquivo).HasMaxLength(255);
            entity.Property(e => e.categoria).HasColumnType("int(255)");
            entity.Property(e => e.nome).HasMaxLength(255);
            entity.Property(e => e.sessao).HasColumnType("int(11)");

            entity.HasOne(d => d.categoriaNavigation).WithMany(p => p.sessoes)
                .HasForeignKey(d => d.categoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_categoria");
        });

        modelBuilder.Entity<status_projetos>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)");
            entity.Property(e => e.status_nome).HasMaxLength(255);
        });

        modelBuilder.Entity<usuario>(entity =>
        {
            entity
                .HasNoKey()
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.email).HasMaxLength(255);
            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.nome).HasMaxLength(255);
            entity.Property(e => e.senha).HasMaxLength(255);
            entity.Property(e => e.user).HasMaxLength(255);
        });

        modelBuilder.Entity<vereador_indicacao>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.id_indicacao, "id_indicacao");

            entity.HasIndex(e => e.id_vereador, "id_vereador");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.id_indicacao).HasColumnType("int(11)");
            entity.Property(e => e.id_vereador).HasColumnType("int(11)");

            entity.HasOne(d => d.id_indicacaoNavigation).WithMany(p => p.vereador_indicacao)
                .HasForeignKey(d => d.id_indicacao)
                .HasConstraintName("vereador_indicacao_ibfk_1");

            entity.HasOne(d => d.id_vereadorNavigation).WithMany(p => p.vereador_indicacao)
                .HasForeignKey(d => d.id_vereador)
                .HasConstraintName("vereador_indicacao_ibfk_2");
        });

        modelBuilder.Entity<vereador_pedido>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.id_vereador, "id_vereador");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.dh_postagem)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.id_pedido).HasColumnType("int(11)");
            entity.Property(e => e.id_vereador).HasColumnType("int(11)");

            entity.HasOne(d => d.id_vereadorNavigation).WithMany(p => p.vereador_pedido)
                .HasForeignKey(d => d.id_vereador)
                .HasConstraintName("vereador_pedido_ibfk_1");
        });

        modelBuilder.Entity<vereador_requerimento>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            entity.HasIndex(e => e.id_requerimentos, "id_pedido");

            entity.HasIndex(e => e.id_vereador, "id_vereador");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.dh_postagem)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.id_requerimentos).HasColumnType("int(11)");
            entity.Property(e => e.id_vereador).HasColumnType("int(11)");

            entity.HasOne(d => d.id_requerimentosNavigation).WithMany(p => p.vereador_requerimento)
                .HasForeignKey(d => d.id_requerimentos)
                .HasConstraintName("vereador_requerimento_ibfk_2");

            entity.HasOne(d => d.id_vereadorNavigation).WithMany(p => p.vereador_requerimento)
                .HasForeignKey(d => d.id_vereador)
                .HasConstraintName("vereador_requerimento_ibfk_1");
        });

        modelBuilder.Entity<vereadores>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity
                .HasCharSet("latin1")
                .UseCollation("latin1_general_ci");

            entity.Property(e => e.id).HasColumnType("int(11)");
            entity.Property(e => e.ativo).HasColumnType("int(11)");
            entity.Property(e => e.email).HasMaxLength(255);
            entity.Property(e => e.foto).HasMaxLength(255);
            entity.Property(e => e.nome).HasMaxLength(255);
            entity.Property(e => e.id_partido).HasColumnType("int(11)");

            entity.HasOne(v => v.id_partidoNavigation).WithMany(p => p.partido_vereadores)
            .HasForeignKey(v => v.id_partido).HasConstraintName("vereadores_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
