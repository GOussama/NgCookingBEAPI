using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using NgcookingBackend.Models;

namespace NgcookingBackend.V._0.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20160527123911_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NgcookingBackend.Models.Communaute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<DateTime>("Birth");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("Firstname");

                    b.Property<int>("Level");

                    b.Property<string>("Password");

                    b.Property<string>("Picture");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "NgcookingBackend.Models.Communautes");
                });

            modelBuilder.Entity("NgcookingBackend.Models.Recette", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<Guid?>("CommunauteId");

                    b.Property<string>("Name");

                    b.Property<string>("Picture");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "NgcookingBackend.Models.Recettes");
                });

            modelBuilder.Entity("NgcookingBackend.Models.Recette", b =>
                {
                    b.HasOne("NgcookingBackend.Models.Communaute")
                        .WithMany()
                        .HasForeignKey("CommunauteId");
                });
        }
    }
}
