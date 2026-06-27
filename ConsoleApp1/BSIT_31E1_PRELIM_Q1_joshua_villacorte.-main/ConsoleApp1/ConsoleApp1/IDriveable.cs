namespace TransportChallenge;

public interface IDivable
{
    // Just needs to exist for the interface contract
}

public class Submarine : Vehicle, ISailable, IDivable
{
    public override string Move()
    {
        return "Sailing on the water."; // or diving, whatever you prefer!
    }
}