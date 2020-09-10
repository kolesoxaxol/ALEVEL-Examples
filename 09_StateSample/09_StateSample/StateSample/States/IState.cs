namespace StateSample.States
{
    interface IState
    {
        void FillTank();
        void TurnKey();
        void Drive();
        void Stop();
    }
}
