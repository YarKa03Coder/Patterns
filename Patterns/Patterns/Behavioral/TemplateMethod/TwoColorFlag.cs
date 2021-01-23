namespace Patterns.Behavioral.TemplateMethod
{
    public abstract class TwoColorFlag
    {
        public void TemplateMethod()
        {
            DrawTopPart();
            DrawBottomPart();
        }

        protected abstract void DrawTopPart();
        protected abstract void DrawBottomPart();
    }
}