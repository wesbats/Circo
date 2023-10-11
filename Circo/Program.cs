namespace Circo;

class program
{
    static void Main()
    {
        Palhaco Palhaco = new Palhaco("Palhaço 1", 30, DateTime.Now.AddDays(-1), true, true, 15);
        Palhaco.RegistrarSaida();
        Palhaco.ApresentaPalhaco();

        Equilibrista Equilibrista = new Equilibrista("Equilibrista 1", 45, DateTime.Now.AddDays(-2), "Corda", 5.0, 15);
        Equilibrista.ApresentaEquilibrista();

        Malabarista Malabarista = new Malabarista("Malabarista 1", 60, DateTime.Now.AddDays(-3), 5, "Bolas", 2.5);
        Malabarista.RegistrarSaida();
        Malabarista.ApresentaMalabarista();
    }
}
