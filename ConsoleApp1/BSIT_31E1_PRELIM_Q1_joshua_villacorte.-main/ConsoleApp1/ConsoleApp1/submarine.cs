namespace TransportChallenge;

public class submarine : Vehicle, ISailable, IDivable
{
    public override string Move()
    {
        return "Sailing on the water.";
    }
}