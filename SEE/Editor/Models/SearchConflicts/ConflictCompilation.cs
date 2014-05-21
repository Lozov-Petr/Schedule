﻿using System.Collections.Generic;

namespace Editor.Models.SearchConflicts
{

    public enum ConflictCriteria
    {
        All,
        GreaterThanFourClassesPerDay,
        GroupsInDifferentClassrooms,
        LecturersInDifferentClassrooms,
        NextClassesAtDifferentAddress,
        CardsWithBlankFields
    }

    public class ConflictCompilation
    {
        public IEnumerable<Conflict> Conflicts;

        public ConflictCompilation(ClassesSchedule schedule, ConflictCriteria criteria)
        {
            switch (criteria)
            {
                case ConflictCriteria.GreaterThanFourClassesPerDay:
                    Conflicts = ConflictSearchEngine.GreaterThanFourClassesPerDay(schedule);
                    break;
            }
        }
    }
}
