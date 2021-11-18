using DatingService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingService.Persistence.Seeds
{
    public static class DefaultReportCategory
    {
        public static List<ReportCategory> ReportCategoryList()
        {
            return new List<ReportCategory>()
            {
                new ReportCategory {
                    Id = Guid.Parse("6c8b430f-99bf-460d-903e-198728353a72"),
                    Name = "Контент сексуального характера",
                },
                new ReportCategory {
                    Id = Guid.Parse("0d50b5d6-2274-4f74-a478-7671242e1348"),
                    Name = "Жестокие или отталкивающие сцены",
                },
                new ReportCategory {
                    Id = Guid.Parse("83ba1239-4ef7-44a7-ae91-c5c9d0e6c100"),
                    Name = "Оскорбления или проявления нетерпимости",
                },
                new ReportCategory {
                    Id = Guid.Parse("06568472-51b4-4292-b7e0-a220b789c885"),
                    Name = "Вредные или опасные действия",
                },
                new ReportCategory {
                    Id = Guid.Parse("520eeb61-256a-4edd-9476-5fbe69cc3f20"),
                    Name = "Жестокое обращение с детьми",
                },
                new ReportCategory {
                    Id = Guid.Parse("516fff94-dfd1-4c94-bebd-9498048eac3d"),
                    Name = "Нарушение моих прав",
                },
                new ReportCategory {
                    Id = Guid.Parse("bacc901a-c8fd-4f8c-b4f7-30e8a5b0d502"),
                    Name = "Пропаганда терроризма",
                },
                new ReportCategory {
                    Id = Guid.Parse("7eca2608-2bf8-482b-a630-8e7eb2bc8724"),
                    Name = "Спам или ложная информация",
                },
        };
        }
    }
}
