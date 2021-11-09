namespace SupShopUI
{
    public interface IMenuFactory
    {
        /// <summary>
        /// Will be getting the class from directory choice based on the meny type DirectoryChoice
        /// </summary>
        /// <param name="p_menu">This is going to determine what menu it will create</param>
        /// <returns> returns the child class from directorychoice</returns>
        IStoreFront GetMenu(DirectoryChoice p_menu);
    }
}