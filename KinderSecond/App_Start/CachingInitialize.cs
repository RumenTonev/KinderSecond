using KinderSecond.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Data.Entity;

namespace KinderSecond.App_Start
{
    public class CachingInitialize
    {
        public static void CacheContstantData()
        {
            var policy = new CacheItemPolicy();
           // policy.AbsoluteExpiration
            using (var iow = new UowData())
            {
                var quizes = iow.Quizes.All().Include(x => x.Questions).Include("Questions.Answers").ToList();
                    MemoryCache.Default.Set("quizes", quizes, policy);
                MemoryCache.Default.Set("kur", "kuuuuuuuuu", policy);
            }
      }
    }
}