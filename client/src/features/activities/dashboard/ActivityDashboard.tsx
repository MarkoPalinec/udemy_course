import { Grid2 } from "@mui/material";
import React from "react";
import ActivityList from "./ActivityList";
import ActivitzFilters from "./ActivityFilters";

export default function ActivityDashboard() {
  return (
    <Grid2 container spacing={3}>
      <Grid2 size={8}>
        <ActivityList />
      </Grid2>
      <Grid2 size={4}>
        <ActivitzFilters />
      </Grid2>
    </Grid2>
  );
}
