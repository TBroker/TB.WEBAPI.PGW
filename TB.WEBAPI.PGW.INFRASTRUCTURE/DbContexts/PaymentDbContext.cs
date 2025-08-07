using Microsoft.EntityFrameworkCore;
using TB.WEBAPI.PGW.DOMAIN.Entities;

namespace TB.WEBAPI.PGW.INFRASTRUCTURE.DbContexts
{
    public class PaymentDbContext : DbContext
    {
        public DbSet<WebPaymentNotifyLinkKbank> WebPaymentNotifyLinkKbanks { get; set; }
        public DbSet<WebPaymentNotifyCardKBank> WebPaymentNotifyCardKbanks { get; set; }
        public DbSet<WebPaymentNotifyQrKbank> WebPaymentNotifyQrKbanks { get; set; }
        public DbSet<WebPaymentNotifyT2P> WebPaymentNotifyT2Ps { get; set; }

        public PaymentDbContext(DbContextOptions<PaymentDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebPaymentNotifyLinkKbank>().ToTable("web_payment_notify_link_kbank");
            modelBuilder.Entity<WebPaymentNotifyCardKBank>().ToTable("web_payment_notify_card_kbank");
            modelBuilder.Entity<WebPaymentNotifyQrKbank>().ToTable("web_payment_notify_qr_kbank");
            modelBuilder.Entity<WebPaymentNotifyT2P>().ToTable("web_payment_notify_t2p");

            base.OnModelCreating(modelBuilder);
            // Additional configuration
        }
    }
}