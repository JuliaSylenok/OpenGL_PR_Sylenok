using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Lab5.OpenGL;


namespace gl_Lab5
{
    public class RenderSettings
    {
        // Параметри для рендерингу
        public bool IsWireframe { get; set; } = false; // Каркас або заповнення
        public bool OrthoPerspective { get; set; } = true; // Ортографічна чи перспективна проекція

        // Подія для оновлення рендера
        public event Action SettingsChanged;

        // Методи для зміни параметрів з інтерфейсу
        public void SetWireframeMode(bool isWireframe)
        {
            IsWireframe = isWireframe;
            SettingsChanged?.Invoke(); 
            // Викликаємо подію оновлення
        }

        public void SetProjectionMode(bool orthoPerspective)
        {
            OrthoPerspective = orthoPerspective;
            SettingsChanged?.Invoke(); // Викликаємо подію оновлення
        }
    }

}
