using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;

namespace Infrastructure.Listeners
{
    public class EmailSubscriber: ISubscriber
    {
        public void Notify(string message, IEmployee employee)
        {
            Console.WriteLine($"Email message for: {employee}\n Message: {message}");
        }
    }
}
