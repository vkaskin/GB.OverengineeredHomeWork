
namespace OverengineeredHomeWork.Core
{
    public class ProgramSwitcher                      //Сontext of the Strategy pattern
    {
        private INumberProcessor program;

        public ProgramSwitcher(INumberProcessor program)
        {
            this.program = program;
        }

        /// <summary>
        /// 
        /// </summary>
        public void RunProgramm() => program.Run();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="program"></param>
        public void SetProgram(INumberProcessor program) => this.program = program;
    }
}
