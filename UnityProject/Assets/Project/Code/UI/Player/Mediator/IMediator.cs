namespace Project.Code.Player.Mediator {
    public interface IMediator<T> {
        public void Sender<T1>(T obj, T1 ActionEvent);
    } 
}
