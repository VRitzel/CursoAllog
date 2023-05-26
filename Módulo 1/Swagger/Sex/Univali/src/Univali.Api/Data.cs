using Univali.Api.Entities;

namespace Univali.Api{
    public class Data{
        private static Data? instance;
        public List<Customer> Customers {get;set;} 
        private Data(){
            Customers = new List<Customer>(){
                new Customer{
                    Id = 1,
                    Name = "Linus",
                    CPF = "1234567890"
                },
                new Customer{
                    Id = 2,
                    Name = "Bill Gates",
                    CPF = "2345678901"
                }
            };
        }

        public static Data getInstance(){
            if(instance == null){
                instance = new Data();
            }
            return instance;
        }
    }
}