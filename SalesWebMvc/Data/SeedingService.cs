using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Eletronics");
            Department d2 = new Department(2, "Clothes");
            Department d3 = new Department(3, "Games");
            Department d4 = new Department(4, "Computers");

            Seller s1 = new Seller(1, "Bob", "bob@email.com", new DateTime(1995, 02, 10), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria", "maria@email.com", new DateTime(1997, 07, 18), 1700.0, d1);
            Seller s3 = new Seller(3, "João", "joao@email.com", new DateTime(1987, 05, 12), 2500.00, d1);
            Seller s4 = new Seller(4, "Maria", "maria@email.com", new DateTime(1990, 08, 20), 3000.00, d1);
            Seller s5 = new Seller(5, "Pedro", "pedro@email.com", new DateTime(1985, 03, 07), 2800.00, d2);
            Seller s6 = new Seller(6, "Ana", "ana@email.com", new DateTime(1992, 10, 06), 4000.00, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 01, 10), 5000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 01, 15), 7000.0, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 01, 20), 9000.0, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 02, 05), 6000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 02, 10), 8000.0, SaleStatus.Pending, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 02, 15), 10000.0, SaleStatus.Canceled, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 03, 01), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 03, 05), 6000.0, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 03, 10), 8000.0, SaleStatus.Canceled, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 04, 01), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 04, 05), 7000.0, SaleStatus.Pending, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 04, 10), 9000.0, SaleStatus.Canceled, s6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 05, 01), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 05, 05), 8000.0, SaleStatus.Pending, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 05, 10), 10000.0, SaleStatus.Canceled, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 06, 01), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 06, 05), 6000.0, SaleStatus.Pending, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 06, 10), 8000.0, SaleStatus.Canceled, s6);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 07, 01), 5000.0, SaleStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 07, 05), 7000.0, SaleStatus.Pending, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 07, 10), 9000.0, SaleStatus.Canceled, s3);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 08, 01), 6000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 08, 05), 8000.0, SaleStatus.Pending, s5);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 08, 10), 10000.0, SaleStatus.Canceled, s6);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 09, 01), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 09, 05), 6000.0, SaleStatus.Pending, s2);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 09, 10), 8000.0, SaleStatus.Canceled, s3);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 10, 01), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 10, 05), 7000.0, SaleStatus.Pending, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 10, 10), 9000.0, SaleStatus.Canceled, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
