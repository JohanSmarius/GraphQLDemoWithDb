// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");

var httpClient = new HttpClient();

var queryJSON = "{\"query\": \"query getOrders {orders {orderLines {product {name}}customer {name}}}\"}";
var data = new StringContent(queryJSON, Encoding.UTF8, "application/json");

var result = await httpClient.PostAsync("https://localhost:7189/graphql/", data);

Console.WriteLine($"Call returned statuscode {result.StatusCode}");
var receivedData = await result.Content.ReadAsStringAsync();
Console.WriteLine();
Console.WriteLine(receivedData);