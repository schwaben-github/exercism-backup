class Lasagna
{
    int lasagnaExpected = 40;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int lasagnaActual) => (lasagnaExpected - lasagnaActual);

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return (layers * 2);
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int lasagnaElapsed)
    {
        return ((layers * 2) + lasagnaElapsed);
    }
}
