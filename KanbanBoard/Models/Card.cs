﻿namespace KanbanBoard.Models
{
	public sealed class Card
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Order { get; set; }
		public int? ColumnId { get; set; }
		public Column Column { get; set; }
	}
}