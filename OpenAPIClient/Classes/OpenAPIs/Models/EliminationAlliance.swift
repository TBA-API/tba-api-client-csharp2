//
// EliminationAlliance.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation



public struct EliminationAlliance: Codable {

    /** Alliance name, may be null. */
    public var name: String?
    public var backup: EliminationAllianceBackup?
    /** List of teams that declined the alliance. */
    public var declines: [String]?
    /** List of team keys picked for the alliance. First pick is captain. */
    public var picks: [String]
    public var status: EliminationAllianceStatus?

    public init(name: String?, backup: EliminationAllianceBackup?, declines: [String]?, picks: [String], status: EliminationAllianceStatus?) {
        self.name = name
        self.backup = backup
        self.declines = declines
        self.picks = picks
        self.status = status
    }


}

