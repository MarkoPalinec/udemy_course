import { Grid2 } from "@mui/material";
import React from "react";
import ActivityList from "./ActivityList";

export default function ActivityDashboard() {
  return (
    <Grid2 container spacing={3}>
      <Grid2 size={7}>
        <ActivityList />
      </Grid2>
      <Grid2 size={5}>activity filters shal be here</Grid2>
    </Grid2>
  );
}
