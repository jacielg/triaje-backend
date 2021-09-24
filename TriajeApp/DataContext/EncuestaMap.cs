using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TriajeApp.Models;

namespace TriajeApp.DataContext
{
    public class EncuestaMap : IEntityTypeConfiguration<Encuesta>
    {
        public void Configure(EntityTypeBuilder<Encuesta> builder)
        {
            builder.ToTable("Encuesta", "dbo");
            builder.HasKey(q => q.encuestaId);
            builder.Property(e => e.encuestaId).IsRequired().UseIdentityColumn();
            builder.Property(e => e.encuestaFecha).HasColumnType("datetime").IsRequired();
            builder.Property(e => e.encuestaTipo).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoBarcode).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoDNI).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoNombre).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoTelefono).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoSexo).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoEdad).HasColumnType("int").IsRequired();
            builder.Property(e => e.empresaNombre).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empresaEdificio).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empresaNivel).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.kitBienvenida).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoTemperatura).HasColumnType("int").IsRequired();
            builder.Property(e => e.haViajado).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.cercaniaCovid).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoSintomas).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.alertaIncapacidad).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.reintegroIncapacidad).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoIncapacitado).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(e => e.empleadoVacunado).HasColumnType("nvarchar(max)").IsRequired();
        }
    }
}
