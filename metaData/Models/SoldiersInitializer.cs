using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace metaData.Models
{
    public class SoldiersInitializer : DropCreateDatabaseAlways<SoldiersDB>
    {

        protected override void Seed(SoldiersDB context)
        {
            base.Seed(context);

            var soldiers = new List<Soldier>
        {
            new Soldier
            {
                soldierId = 123456789,
                name = "Joe Schmoe",
                ETS = 01072020
            }
        };
            soldiers.ForEach(s => context.Soldiers.Add(s));

            context.SaveChanges();
        }
    }
}