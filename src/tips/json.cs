// work with JSON

// using Newtonsoft,Josn
string json = JsonConvert.SerializeObject(student);
var obj = JsonConvert.DeserializeObject<Student>(json);

// using System.Text.Json
string json = JsonSerializer.Serialize(student);
var obj2 = JsonSerializer.Deserialize<Student>(json);

// using NetJSON
string json = NetJSON.Serialize(student);
var obj3 = NetJSON.Deserialize<Student>(json);