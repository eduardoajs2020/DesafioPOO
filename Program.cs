using DesafioPOO.Models;


Iphone meuIphone = new Iphone("987654321", "iPhone 13 Pro Max", "356895-03-765432-9", 256);

meuIphone.Ligar(); //Efetua chamada
meuIphone.ReceberLigacao(); // Atende uma chamada
meuIphone.InstalarAplicativo("Instagram"); // Instala o aplicativo Instagram
meuIphone.CarregarBateria(); // Carrega a bateria do iPhone

// Test with smartphone Nokia (derived class)
Nokia meuNokia = new Nokia("333222111", "Nokia X20", "359762-09-123456-7", 64);

meuNokia.Ligar(); // Efetua chamada
meuNokia.ReceberLigacao(); // Atende uma chamada
meuNokia.InstalarAplicativo("Facebook"); // Instala o aplicativo Facebook
meuNokia.CarregarBateria(); // Carrega a bateria do Nokia
