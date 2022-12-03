﻿using System.Text;
using Nodsoft.MoltenObsidian.Vault;

namespace Nodsoft.MoltenObsidian.Vaults.FileSystem.Data;

internal sealed class FileSystemVaultNote : FileSystemVaultFile, IVaultNote
{
	public FileSystemVaultNote(FileInfo file, IVaultFolder parent, IVault vault) : base(file, parent, vault) { }
	
	public override string ContentType => "text/markdown";
	
	public ObsidianText ReadDocument() => new(Encoding.UTF8.GetString(ReadAllBytes()), this);
}