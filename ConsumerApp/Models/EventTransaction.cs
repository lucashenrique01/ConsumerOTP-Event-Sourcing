using System;
namespace ConsumerApp.Models
{
    public class EventTransaction
    {
        public string token {get; set;}
        public string idClient {get; set;}
        public string idTransacao {get; set;}
        public string canalSolicitante {get; set;}
        public DateTime duracaoToken  {get; set;}

        public EventTransaction(){
            
        }

        

    }
}