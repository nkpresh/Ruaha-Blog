using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace RuahaBlog.Models
{
    public static class ModelBuilderExtensi
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BogPost>().HasData(
                new BogPost
                {
                    Id = 1,
                    category = Category.Cars,
                    Headline = "The New Ride is Mind Blowing",
                    WriteUp = "The new 2020 Chevrolete Camaro is so cute;" +
                    " It actually came late because of the corona virus " +
                    "pandemic and #Endsars protest  but,hey!, " +
                    "thank goodness; it's here and it's not disappointing. The " +
                    "features are madd but yet not everybody likes it.",
                    Visible = true,
                    Name="Peter",
                },
                new BogPost
                {
                    Id=2,
                    category=Category.Entertainment,
                    Headline="Some people have real problems",
                    WriteUp="The popular musician who goes by the name Sia Fura, used to be a drug addict who was so messed up, she almost commited " +
                    "suicide when she lost her boy friend, but was saved by a phone call, but guess what; now she's a celebrity who has nothing to do" +
                    "with drugs and she's living her best life. Her music has inspired me a lot of times and that's why I chose to write about her." +
                    "In life, sometimes we face some matture problems that try to weigh us down, some of those times we don't even recieve that one " +
                    "phone that is supposed to save us; maybe God want's us to be our own heros to save our own lives, don't let yourself down, keep pushing" +
                    "#Real problems",
                    Visible=true,
                    Name="Mum"
                }
                    ) ;
        }
    }
}
