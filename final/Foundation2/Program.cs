using System;


class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("14 Dixie Gulf St", "Gatorsville", "MS", "United States");
        Customer customer1 = new Customer("Biloxi Buckwater", address1);
        Product product1 = new Product("The Devil's own Betrothed Cajun Hot Sauce", "194A1H3", 2.99, 2);
        Product product2 = new Product("Baby's First Gator Skinning Toolkit", "2F2345X", 24.50, 7);;
        Product product3 = new Product("Bayou Betsy's Guide to Porcelain and Appliance Landscaping", "3HJA987", 11.99, 1);

        Address address2 = new Address("26 Rua Governador Pedro Álvares Cabral da Sousa de Lima Santos Medeiros Hiroshi Azevedo da Cruz Moraes Sena", "Rio das Águas", "RN", "Brazil");
        Customer customer2 = new Customer("Vinicius Júlio Cesar Ferreira de Almeida Wanderley Rosa da Silva de Jesus da Maria José de Belém Silva Nascimento Álves", address2);
        Product product4 = new Product("Chicago Bulls Jersey", "345GAS4", 23.00, 1);
        Product product5 = new Product("Playstation 4", "A1ASDF2", 399.99, 1);
        Product product6 = new Product("Produto Baratinho que Vende-se no Site Americano", "9A43545", .99, 12);

        List<Product> cart1 = new List<Product>();
        cart1.Add(product1);
        cart1.Add(product2);
        cart1.Add(product3);
        Order order1 = new Order(customer1, cart1);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetTotalCost());

        Console.WriteLine();

        List<Product> cart2 = new List<Product>();
        cart2.Add(product4);
        cart2.Add(product5);
        cart2.Add(product6);
        Order order2 = new Order(customer2, cart2);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetTotalCost());

    }
}