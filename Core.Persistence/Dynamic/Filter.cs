using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dynamic
{
    //system.Linq.dynamic nuget ekle
    public class Filter
    {
        public string Field {  get; set; }
        public string? Value { get; set; }   
        public string Operator {  get; set; }
        public  string? Logic { get; set; }

        public IEnumerable<Filter>? Filters { get; set; } //Filter'ın içinde başka filtre çağırabilir.

        public Filter() { 
        
        Field = string.Empty;
        Operator = string.Empty;
        
        }
        public Filter(string field, string @operator) //operator c# 'da var bizim verdiğimiz için @ koyduk başına
        {
            Field = field;
            Operator = @operator;
        }

    }
}
