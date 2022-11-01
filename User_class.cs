class User //Class yang berisikan tentang user
{
    private int id { get; set; }
    private string userName { get; set; } 
    private string email { get; set; }
    private string password { get; set; }
    private List<string> favourite_list = new List<string>();

    public User(int Id, string Username, string Email, string Pass, List<string> FavouriteList)
    {
        id = Id;
        userName = Username;
        email = Email;
        password = Pass;
        favourite_list = FavouriteList;
    }
    public newUser()
    {

    }
    public login()
    {

    }
    public addFavourite()
    {

    }
}
