# PizarrApp 📌

**PizarrApp** es una aplicación diseñada para gestionar de forma centralizada tanto la lista de la compra como las tareas del hogar. Todos los miembros de la vivienda pueden añadir productos, marcar artículos comprados, crear tareas domésticas y consultar el estado general del hogar en tiempo real.

---

## 🚀 Características

* **Lista de la compra compartida:** Añade productos y marca los artículos que ya han sido comprados.
* **Gestión de tareas:** Crea y organiza los quehaceres domésticos asignados a la vivienda.
* **Estado general:** Consulta rápida del estado de organización de la casa desde un panel centralizado.

---

## 🛠️ Tecnologías Utilizadas

* **Entorno de Desarrollo:** Visual Studio
* **Lenguaje/Framework:** C# / .NET MAUI o Xamarin (Multi-platform App UI) *[Nota: Ajustar si aplica]*
* **Despliegue:** Generación de paquete APK para Android.

---

## 📂 Estructura del Proyecto

El desarrollo de la aplicación se divide en las siguientes vistas y componentes principales:
* `MainPage`: Pantalla principal del sistema y centro de control.
* `CompraPage`: Interfaz dedicada a la gestión de la lista de la compra.
* `TareasPage`: Panel de control de las tareas del hogar.
* `ClaseProducto` / `ClaseTarea`: Modelos de datos subyacentes para la lógica de la app.

---

## 📦 Instalación y Uso

### Requisitos previos
* Visual Studio con la carga de trabajo para desarrollo móvil instalada.
* Un dispositivo Android o emulador para instalar el archivo APK.

### Ejecución en desarrollo
1. Clona este repositorio:
   ```bash
   git clone https://github.com
   ```
2. Abre el archivo de solución (`.sln`) en **Visual Studio**.
3. Compila el proyecto y selecciona tu emulador o dispositivo físico para iniciar la depuración.

---

## 👥 Equipo Dev (Participantes)

El desarrollo de este proyecto ha sido posible gracias al trabajo en equipo de:

* **Unax Vizcaíno** 
  * 💻 Desarrollo de `MainPage` y lógica de navegación.
* **Marina Redondo** 
  * 🛠️ Creación y modelado de `ClaseProducto`.
* **Eneritz Kareaga** 
  * 🛒 Desarrollo y diseño de `CompraPage`.
* **Erlantz Amigo** 
  * 📝 Desarrollo de `ClaseTarea` y la vista `TareasPage`.
* **Ibai López de Lerena** 
  * 🧪 Control de calidad, plan de pruebas y generación del archivo APK final.
