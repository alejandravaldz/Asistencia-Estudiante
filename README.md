# 📘 Proyecto: Control de Asistencia en C#

## 📌 Descripción
Este programa permite al usuario **registrar clientes** mediante un formulario con validación de campos y un **ListBox** que acumula los clientes registrados.  
Su objetivo es garantizar que los datos ingresados (Nombre, Teléfono y Correo) sean obligatorios y se almacenen de manera dinámica en la aplicación.

---

## 🚀 Funcionalidades
- Entrada de datos mediante campos de texto (**Nombre, Teléfono, Correo**).
- Validación de campos obligatorios (no permite guardar si falta algún dato).
- Almacenamiento dinámico en una lista de clientes.
- Limpieza automática de los campos tras guardar un registro.

---

## 🛠️ Tecnologías utilizadas
- Lenguaje: **C#**
- Entorno: **Aplicación de Windows Forms**

---

## 📂 Estructura del código
El programa se organiza de la siguiente manera:

- **Espacio de Nombre:** `Registro_Cliente`  
- **Clase principal:** `Form1`  
- **Evento:** `btn_Guardar_Click`  
  - Valida que los campos no estén vacíos.  
  - Muestra un mensaje de advertencia si falta algún campo por llenar.  
  - Agrega el nuevo cliente a la lista.  
  - Limpia los campos para nueva entrada de datos.  

---

## 🖼️ Captura de Ejecución
<img width="980" height="740" alt="Captura de pantalla 2026-07-31 010104" src="https://github.com/user-attachments/assets/c33f53d1-e15b-4cdb-b53e-a7801ed8f8b3" />

<img width="1138" height="738" alt="Captura de pantalla 2026-07-31 010323" src="https://github.com/user-attachments/assets/d6c8bd6f-ddae-4ade-9cbb-eb42c0607977" />
 de listas dinámicas.
