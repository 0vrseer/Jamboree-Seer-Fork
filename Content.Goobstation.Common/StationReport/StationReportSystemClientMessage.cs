// SPDX-FileCopyrightText: 2025 JamboreeBot <JamboreeBot@proton.me>
// SPDX-FileCopyrightText: 2025 JohnJohn <189290423+JohnJJohn@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Goobstation.Common.StationReport;
using Robust.Shared.GameObjects;

namespace Content.Goobstation.Common.StationReport;

public sealed class StationReportSystem : EntitySystem
{
    //stores the last received station report
    public string? StationReportText { get; private set; } = null;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeNetworkEvent<StationReportEvent>(OnStationReportReceived);
    }

    private void OnStationReportReceived(StationReportEvent ev)
    {
        //Save the received message in the variable
        StationReportText = ev.StationReportText;
    }
}
