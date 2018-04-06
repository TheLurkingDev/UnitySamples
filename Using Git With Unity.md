1. Add Unity-specific .gitignore Settings
We recommend GitHub’s Unity .gitignore template.

In addition, depending on the platforms you intend to use for development, you should gitignore common files for macOS and/or Windows.

2. Configure Unity For Version Control
With your project open in the Unity editor:

Open the editor settings window.
Edit > Project Settings > Editor
Make .meta files visible to avoid broken object references.
Version Control / Mode: “Visible Meta Files”
Use plain text serialization to avoid unresolvable merge conflicts.
Asset Serialization / Mode: “Force Text”
Save your changes.
File > Save Project



3. Use Git Large File Storage
Git Large File Storage (LFS) uses Git attributes to track large files with Git, while keeping them out of your actual repository. Note that this will only work if you use GitHub or a server that supports the Git LFS API.

To set it up, download and install the Git LFS command line extension as documented on the Git LFS site.

https://git-lfs.github.com/
