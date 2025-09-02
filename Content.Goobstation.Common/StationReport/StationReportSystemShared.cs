// SPDX-FileCopyrightText: 2025 JamboreeBot <JamboreeBot@proton.me>
// SPDX-FileCopyrightText: 2025 JohnJohn <189290423+JohnJJohn@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Serialization;

namespace Content.Goobstation.Common.StationReport;

[Serializable, NetSerializable]
public sealed class StationReportEvent : EntityEventArgs
{
    //This is where the stationreport is stored so the client can access it
    public string? StationReportText { get; }
    public StationReportEvent(string? text)
    {
        StationReportText = text;
    }
}
