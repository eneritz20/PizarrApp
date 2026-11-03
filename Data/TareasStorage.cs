using System;
using System.Collections.Generic;
using System.Text;
using PizarrApp.Model;
using System.Text.Json;

namespace PizarrApp.Data
{
    public static class TareasStorage
    {
        private static readonly string rutaArchivo = Path.Combine(FileSystem.Current.
           AppDataDirectory, "tareas.json");

        public static bool DatosCargados { get; private set; }

        public static async Task GuardarAsync()
        {
            try
            {
                string json = JsonSerializer.Serialize(TareasData.Tareas);
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

            List<Tarea>? tareasGuardadas = JsonSerializer.Deserialize<List<Tarea>>(json);

            if (tareasGuardadas is null)
                return;
            TareasData.Tareas.Clear();
            foreach (Tarea tarea in tareasGuardadas)
            {
                TareasData.Tareas.Add(tarea);
            }
        }
    }
}
