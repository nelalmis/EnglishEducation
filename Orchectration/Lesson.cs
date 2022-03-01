using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
namespace Orchectration
{
    public class Lesson
    {
        public Types.Lesson SelectByKey()
        {
            Business.Lesson li = new Business.Lesson();
            var response = li.SelectByKey();
            return response;
        }
        public void Insert()
        {

        }
        public void SelectByColumns()
        {

        }
    }
}
