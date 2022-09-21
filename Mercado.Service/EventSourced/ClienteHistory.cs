using Mercado.DomainCore.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Application.EventSourced
{
    public class ClienteHistory
    {
        public static IList<ClienteHistoryData> HistoryData { get; set; }

        public static IList<ClienteHistoryData> ToJavaScriptCustomerHistory(IList<StoredEvent> storedEvents)
        {
            HistoryData = new List<ClienteHistoryData>();
            CustomerHistoryDeserializer(storedEvents);

            var sorted = HistoryData.OrderBy(c => c.When);
            var list = new List<ClienteHistoryData>();
            var last = new ClienteHistoryData();

            foreach (var change in sorted)
            {
                var jsSlot = new ClienteHistoryData
                {

                    ClienteId = change.ClienteId == Guid.Empty.ToString() || change.ClienteId == last.ClienteId
                        ? ""
                        : change.ClienteId,
                    NomeCompleto = string.IsNullOrWhiteSpace(change.NomeCompleto) || change.NomeCompleto == last.NomeCompleto
                        ? ""
                        : change.NomeCompleto,
                    Email = string.IsNullOrWhiteSpace(change.Email) || change.Email == last.Email
                        ? ""
                        : change.Email,
                    Cep = string.IsNullOrWhiteSpace(change.Cep) || change.Cep == last.Cep
                        ? ""
                        : change.Cep,
                    DataNascimento = string.IsNullOrWhiteSpace(change.DataNascimento) || change.DataNascimento == last.DataNascimento
                        ? ""
                        : change.DataNascimento.Substring(0, 10),
                    Action = string.IsNullOrWhiteSpace(change.Action) ? "" : change.Action,
                    When = change.When,
                    Who = change.Who

                };

                list.Add(jsSlot);
                last = change;
            }
            return list;
        }

        private static void CustomerHistoryDeserializer(IEnumerable<StoredEvent> storedEvents)
        {
            foreach (var e in storedEvents)
            {
                var slot = new ClienteHistoryData();
                dynamic values;

                switch (e.MessageType)
                {
                    case "ClienteRegisteredEvent":
                        values = JsonConvert.DeserializeObject<dynamic>(e.Data);
                        slot.Bairro = values["Bairro"];
                        slot.Email = values["Email"];
                        slot.NomeCompleto = values["NomeCompleto"];
                        slot.Action = "Registered";
                        slot.When = values["Timestamp"];
                        slot.ClienteId = values["Id"];
                        slot.Who = values["User"];
                        break;
                    case "ClienteUpdatedEvent":
                        values = JsonConvert.DeserializeObject<dynamic>(e.Data);
                        slot.Bairro = values["Bairro"];
                        slot.Email = values["Email"];
                        slot.NomeCompleto = values["Name"];
                        slot.Action = "Updated";
                        slot.When = values["Timestamp"];
                        slot.ClienteId = values["Id"];
                        slot.Who = values["User"];
                        break;
                    case "ClienteRemovedEvent":
                        values = JsonConvert.DeserializeObject<dynamic>(e.Data);
                        slot.Action = "Removed";
                        slot.When = values["Timestamp"];
                        slot.ClienteId = values["Id"];
                        slot.Who = values["User"];
                        break;
                }
                HistoryData.Add(slot);
            }
        }
    }
}


