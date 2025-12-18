namespace Project.Code.Mediator {
    public interface IMediatorHealth<T> {
        public T GetValueHealth();
        public void UndateHealth();
    }
}