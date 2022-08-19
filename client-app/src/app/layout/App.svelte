<script>
  import axios from "axios";
  import NavBar from "./NavBar.svelte";
  import ActivityDashboard from "../../features/activities/dashboard/ActivityDashboard.svelte";
  import {activitiesList} from "./stores/ActivityStores.js";

  let activities = [];
  axios.get('http://localhost:5000/api/activities').then(response =>{
    activities = response.data;
  }, [])

  $:activitiesList.set(activities)
</script>

<main>
  <NavBar/>
  <div class="container-sm">
    <ActivityDashboard/>
  </div>
</main>
