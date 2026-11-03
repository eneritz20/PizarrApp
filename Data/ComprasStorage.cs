using System;
using System.Collections.Generic;
using System.Text;
using PizarrApp.Model;
using System.Text.Json;

namespace PizarrApp.Data
{
    public static class ComprasStorage
    {
        private static readonly string rutaArchivo = Path.Combine(FileSystem.Current.
           AppDataDirectory, "compras.json");

        public static bool DatosCargados { get; private set; }

        public static async Task GuardarAsync()
        {
            try
            {
                string json = JsonSerializer.Serialize(ComprasData.Productos);
                await File.WriteAllTextAsync(rutaArchivo, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar los datos: {ex.Message}");
            }
        }

        public static async Task CargarArchivo()
        {
            if (DatosCargados)
            {
                return;
            }
            DatosCargados = true;

            if (!File.Exists(rutaArchivo))
            {
                return;
            }
            string json = await File.ReadAllTextAsync(rutaArchivo);

            List<Producto>? productosGuardados = JsonSerializer.Deserialize<List<Producto>>(json);

            if (productosGuardados is null)
                return;
            ComprasData.Productos.Clear();
            foreach (Producto producto in productosGuardados)
            {
                ComprasData.Productos.Add(producto);
            }
        }
    }
}
