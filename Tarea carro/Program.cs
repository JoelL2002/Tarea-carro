using Tarea_carro;

Carro carro = new Carro();

Console.WriteLine($"Marca: {carro.Marca}  Modelo: {carro.Modelo}  Color: {carro.Color} \n\n");

int opcion;
Console.WriteLine("Seleccione que es lo que desea hacer\n");
Console.WriteLine("1. Encender el motor\n" + "2. Apagar el motor\n" + "3. Acelerar\n" + "4. Desacelerar\n" + "5. Frenar\n" + "6. Bocinar\n");
Console.WriteLine("Si desea acelerar, primero debera encender el motor y si desea desacelerar debera haber acelerado primero");
do
{
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            {
                carro.EncenderMotor();
                Console.WriteLine($"El carro esta encendido velocidad actual: {carro.GetVelocidadActual()}KPH");
                opcion = 0;
            }
            break;

        case 2:
            {
                carro.Apagarmotor();                
                Console.Clear();
                Console.WriteLine("Seleccione que es lo que desea hacer\n");
                Console.WriteLine("1. Encender el motor\n" + "2. Apagar el motor\n" + "3. Acelerar\n" + "4. Desacelerar\n" + "5. Frenar\n" + "6. Bocinar\n");
                Console.WriteLine("Si desea acelerar, primero debera encender el motor y si desea desacelerar debera haber acelerado primero\n");
                Console.WriteLine("El carro se ha apagado");
            }
            break;

        case 3:
            {
                carro.acelerar();
                Console.WriteLine($"Velocidad actual: {carro.GetVelocidadActual()}KPH");
                opcion = 0;
            }
            break;

        case 4:
            {
                carro.desacelerar();
                Console.WriteLine($"Velocidad actual: {carro.GetVelocidadActual()}KPH");
                opcion = 0;
            }
            break;

        case 5:
            {
                carro.Frenar();
                Console.WriteLine($"Velocidad actual: {carro.GetVelocidadActual()}KPH");
                opcion = 0;
            }
            break;

        case 6:
            {
                Console.WriteLine(carro.Bocinar());
                opcion = 0;
            }
            break;            
    }
    
} while (opcion < 6);
    


