using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaaldoCom.Services.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class redo_knowledge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Knowledge WHERE 1=1");

            migrationBuilder.InsertData(
                table: "Knowledge",
                columns: ["Title", "Quote"],
                values: new object[,]
                {
                    { "DISCIPLINE OVER MOTIVATION", "Motivation fades. Discipline remains. Build habits that carry you when feelings fall short." },
                    { "QUIET CONSISTENCY", "Small actions done daily will outlast bursts of intensity." },
                    { "CRAFTSMANSHIP", "Do it once. Do it right. Do it in a way your future self will respect." },
                    { "RESILIENT MINDSET", "Pressure reveals the strength you have been quietly building." },
                    { "SIMPLICITY WINS", "Sophistication often comes from removing what does not belong." },
                    { "STAY CURIOUS", "The moment you stop asking why is the moment you stop growing." },
                    { "BUILT TO LAST", "Build habits and systems that can weather time and trial." },
                    { "LEAD YOURSELF FIRST", "Before leading others, master the discipline of leading yourself." },
                    { "FOCUSED ENERGY", "Where attention goes, progress follows." },
                    { "STEADY IMPROVEMENT", "Improve a little each day and outpace your former self." },
                    { "COURAGE TO BEGIN", "You do not need the whole path, only courage for the next step." },
                    { "CHARACTER FIRST", "Talent opens doors, but character determines how long you stay." },
                    { "PATIENT STRENGTH", "Strength is built quietly long before it is tested." },
                    { "PURPOSEFUL WORK", "Work on what matters and let the noise fall away." },
                    { "ENDURING FAITH", "Stand firm in belief even when results take time." },
                    { "CALM UNDER PRESSURE", "A steady mind outperforms a frantic one." },
                    { "OWNERSHIP", "Take responsibility and you take control." },
                    { "LONG VIEW", "Play the long game and let patience compound." },
                    { "GUARD YOUR TIME", "Time invested wisely becomes a life well lived." },
                    { "SHARPEN THE EDGE", "Refine your craft daily and dullness will never win." },
                    { "INTEGRITY ALWAYS", "Do right even when no one is watching." },
                    { "EARNED CONFIDENCE", "Confidence grows where preparation lives." },
                    { "STRONG FOUNDATIONS", "What you build on determines how high you rise." },
                    { "INTENTIONAL LIVING", "Drift is default; intention is design." },
                    { "PERSISTENT EFFORT", "Effort repeated becomes excellence revealed." },
                    { "CLARITY OVER CHAOS", "Clear priorities quiet a noisy world." },
                    { "MEASURED RESPONSE", "Respond with thought, not reaction." },
                    { "RISE EARLY", "Win the morning and you steady the day." },
                    { "PROTECT YOUR FOCUS", "Guard your focus like your future depends on it." },
                    { "DAILY REPS", "Greatness is a collection of ordinary days done well." },
                    { "UNSEEN PREPARATION", "What you practice in private shows in public." },
                    { "HUMBLE GROWTH", "Stay teachable and you will stay growing." },
                    { "FINISH STRONG", "Start with courage and finish with discipline." },
                    { "COMPOUNDING HABITS", "Small habits compound into significant change." },
                    { "BUILT THROUGH TRIALS", "Hard seasons forge durable character." },
                    { "REFUSE AVERAGE", "Do not settle for average when excellence is possible." },
                    { "SERVE FIRST", "Leadership begins with serving well." },
                    { "MASTER THE BASICS", "Excellence hides inside the fundamentals." },
                    { "ACT WITH PURPOSE", "Move with intention, not impulse." },
                    { "RESIST COMFORT", "Comfort rarely creates growth." },
                    { "HOLD THE LINE", "Stand firm when pressure invites compromise." },
                    { "GRATEFUL STRENGTH", "Gratitude strengthens perspective." },
                    { "STAY THE COURSE", "Consistency beats intensity over time." },
                    { "EARN YOUR REST", "Work diligently and rest confidently." },
                    { "SPEAK LESS, DO MORE", "Let your results speak louder than your words." },
                    { "BUILD IN SILENCE", "Grow quietly and let success make the noise." },
                    { "MINDSET MATTERS", "Your outlook shapes your outcome." },
                    { "ONE MORE STEP", "Progress often hides behind one more effort." },
                    { "GUARD YOUR STANDARDS", "Standards kept daily shape identity." },
                    { "PREPARED MIND", "Opportunity favors the prepared." },
                    { "DISCIPLINE DAILY", "Daily discipline defeats rare bursts of effort." },
                    { "VALUE DEPTH", "Depth of skill outlasts width of distraction." },
                    { "FAITHFUL IN SMALL", "Faithfulness in small things builds trust in larger ones." },
                    { "COURAGEOUS INTEGRITY", "Integrity requires courage when compromise is easy." },
                    { "DESIGN YOUR LIFE", "If you do not design your life, drift will design it for you." },
                    { "EFFORT MULTIPLIED", "Effort multiplied by time becomes mastery." },
                    { "STRENGTH IN RESTRAINT", "Power controlled is greater than power displayed." },
                    { "CLIMB STEADILY", "Move forward even when progress feels slow." },
                    { "OWN THE OUTCOME", "Excuses weaken; ownership strengthens." },
                    { "THINK LONG TERM", "Short-term comfort trades long-term growth." },
                    { "STAY GROUNDED", "Success is safest when humility anchors it." },
                    { "REFINE DAILY", "Refinement is a lifelong discipline." },
                    { "BUILD TRUST", "Trust is earned in drops and lost in buckets." },
                    { "LEAD BY EXAMPLE", "Example persuades where words cannot." },
                    { "PURPOSE OVER POPULARITY", "Choose what is right over what is applauded." },
                    { "CONTROL THE CONTROLLABLE", "Focus on what you can influence." },
                    { "PERSISTENT COURAGE", "Courage repeated becomes confidence." },
                    { "SHARPEN CHARACTER", "Character honed daily becomes unshakeable." },
                    { "MEASURED AMBITION", "Ambition guided by wisdom builds wisely." },
                    { "RESILIENT HEART", "A steady heart endures storms." },
                    { "THINK BEFORE ACTING", "Pause creates space for wisdom." },
                    { "BUILD MARGIN", "Margin protects you when life compresses." },
                    { "SEEK EXCELLENCE", "Pursue excellence even when unnoticed." },
                    { "ENDURE THE PROCESS", "The process shapes the person." },
                    { "INVEST IN GROWTH", "Growth is an investment, not an accident." },
                    { "STEADY RESOLVE", "Resolve turns intention into action." },
                    { "HONOR COMMITMENTS", "Keep promises even when inconvenient." },
                    { "LEGACY MINDSET", "Live in a way that outlives you." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
