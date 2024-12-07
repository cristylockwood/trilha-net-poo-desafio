using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Criando instâncias das classes Nokia e Iphone
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "111111111111111", 16);
        Smartphone iphone = new Iphone("987654321", "iPhone 12", "222222222222222", 64);

        // Testando o método Ligar
        nokia.Ligar();
        iphone.Ligar();

        // Testando o método ReceberLigacao
        nokia.ReceberLigacao();
        iphone.ReceberLigacao();

        // Testando o método InstalarAplicativo
        nokia.InstalarAplicativo("WhatsApp");
        iphone.InstalarAplicativo("Instagram");