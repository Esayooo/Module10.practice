using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.practice
{
    // 定义接口 IPart，表示房屋的各个部分
    public interface IPart
    {
        void Build();
    }
    // 实现房屋的各个部分
    public class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Basement");
        }
    }
    public class Wall : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Wall");
        }
    }
    public class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Door");
        }
    }
    public class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Window");
        }
    }
    public class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Roof");
        }
    }
    // 定义接口 IWorker，表示建造者的基本功能
    public interface IWorker
    {
        void Work();
    }
    // 实现建造者和团队领导
    public class Builder : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Builder is working");
        }
    }
    public class Foreman : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Foreman is supervising");
        }

        public void ReportProgress(List<IPart> parts)
        {
            Console.WriteLine("Report from Foreman:");
            foreach (var part in parts)
            {
                Console.WriteLine($"- {part.GetType().Name} has been built");
            }
        }
    }
    // 定义建造团队
    public class BuilderTeam
    {
        private List<IPart> parts;

        public BuilderTeam()
        {
            parts = new List<IPart>();
        }

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public void StartBuilding()
        {
            foreach (var part in parts)
            {
                part.Build();
            }
        }

        public void ShowProgress(Foreman foreman)
        {
            foreman.ReportProgress(parts);
        }
    }

    // 定义房子
    public class House
    {
        public static void Main()
        {
            // 创建房屋部件
            Basement basement = new Basement();
            Wall wall1 = new Wall();
            Wall wall2 = new Wall();
            Wall wall3 = new Wall();
            Wall wall4 = new Wall();
            Door door = new Door();
            Window window1 = new Window();
            Window window2 = new Window();
            Window window3 = new Window();
            Window window4 = new Window();
            Roof roof = new Roof();

            // 创建建造者和团队领导
            Builder builder = new Builder();
            Foreman foreman = new Foreman();

            // 创建建造团队并添加部件
            BuilderTeam builderTeam = new BuilderTeam();
            builderTeam.AddPart(basement);
            builderTeam.AddPart(wall1);
            builderTeam.AddPart(wall2);
            builderTeam.AddPart(wall3);
            builderTeam.AddPart(wall4);
            builderTeam.AddPart(door);
            builderTeam.AddPart(window1);
            builderTeam.AddPart(window2);
            builderTeam.AddPart(window3);
            builderTeam.AddPart(window4);
            builderTeam.AddPart(roof);

            // 建造团队开始工作
            builderTeam.StartBuilding();

            // 团队领导报告进度
            builderTeam.ShowProgress(foreman);

            Console.WriteLine("House construction is complete!");
        }
    }

}
