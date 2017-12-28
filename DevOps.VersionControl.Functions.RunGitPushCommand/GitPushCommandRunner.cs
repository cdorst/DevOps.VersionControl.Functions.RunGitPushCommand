using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitPushCommand
{
    public static class GitPushCommandRunner
    {
        private const string push = nameof(push);

        public static void Push(string directory, params string[] arguments)
            => Git(directory,
                command: push,
                arguments);
    }
}
