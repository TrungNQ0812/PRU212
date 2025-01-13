using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RePractice
{
    internal interface IManager
    {
        void InputList(int size);
        void ShowList();
        int Count();
        void ShowSoCon(int n);
        void SortBySalary();
        void Delete(int n);
        void ShowByName(string name);
        void UpdateSalary();

    }
}
