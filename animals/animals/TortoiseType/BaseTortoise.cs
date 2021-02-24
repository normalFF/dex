namespace animals.TortoiseType
{
    public abstract class BaseTortoise
    {
        protected string _name { get; set; }
        protected string _body { get; set; }
        protected string _shell { get; set; }

        protected BaseTortoise(string _name, string _body, string _shell)
        {
            this._name = _name;
            this._body = _body;
            this._shell = _shell;
        }

        public abstract void ShowInfo();
    }
}
