namespace LuckyLottery.Data
{
    using LuckyLottery.Models;
    using Microsoft.EntityFrameworkCore;
    public class LotteryDbContext : DbContext
    {
        public LotteryDbContext(DbContextOptions<LotteryDbContext> options)
            : base(options)
        {

        }

        public DbSet<LottoAtDraw> LottoAtDraws { get; set; }
        public DbSet<LottoAtPlayedCombinations> LottoAtPlayedCombinations { get; set; }

        public DbSet<EuroMillionenAtDraw> EuroMillionenAtDraws { get; set; }
        public DbSet<EuroMillionenAtPlayedCombination> EuroMillionenAtPlayedCombinations { get; set; }
    }
}
