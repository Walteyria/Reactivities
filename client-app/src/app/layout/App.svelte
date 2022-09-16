<script>
  import NavBar from "./NavBar.svelte";
  import ActivityDashboard from "../../features/activities/dashboard/ActivityDashboard.svelte";
  import {activitiesList} from "../stores/ActivityStores.js";
  import agent from "../api/agent.js";

  let activities = [];
  agent.Activities.list().then(response =>{
    activities = response;
  }, [])
  $:activitiesList.set(activities)
</script>

<main>
  <NavBar/>
  <div class="container-sm">
    <ActivityDashboard/>
  </div>
</main>
