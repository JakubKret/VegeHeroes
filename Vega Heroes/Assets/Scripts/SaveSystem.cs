using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {

    public static void SaveRecipes(RecipesArrays recipe)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/recipe.arrays";
        FileStream stream = new FileStream(path, FileMode.Create);

        RecipesData data = new RecipesData(recipe);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static void SaveCaprices(Caprices caprice)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/recipe.caprice";
        FileStream stream = new FileStream(path, FileMode.Create);

        RecipesData data = new RecipesData(caprice);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static RecipesData LoadRecipes()
    {
        string path = Application.persistentDataPath + "/recipe.arrays";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            RecipesData data = formatter.Deserialize(stream) as RecipesData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    public static RecipesData LoadCaprices()
    {
        string path = Application.persistentDataPath + "/recipe.caprice";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            RecipesData data = formatter.Deserialize(stream) as RecipesData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

}
