using Newtonsoft.Json;
using Учфь;


Event.Events();

string jsonObj = @"{
    ""userId"": 1,
    ""id"": 1,
    ""title"": ""sunt aut facere repellat provident occaecati excepturi optio reprehenderit"",
    ""body"": ""quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto""
  }";


var person = JsonConvert.DeserializeObject<Person>(jsonObj);
Console.WriteLine($"{person.userId}|{person.id}|{person.title}|{person.body}");
