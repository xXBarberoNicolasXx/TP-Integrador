using System;

namespace integrador.Save
{
    internal class ListaGuardado
    {
    }
	{
        string jsonData = JsonConvert.SerializeObject(saveList);
        string filePath = @"Save\save.json";
        File.WriteAllText(filePath, jsonData);
    }
}
