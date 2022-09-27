<script>
  import { Router, Route } from "svelte-routing";
  import HomePage from "../../features/home/HomePage.svelte";
  import ActivityForm from "../../features/activities/form/ActivityForm.svelte";
  import NavBar from "./NavBar.svelte";
  import ActivityDashboard from "../../features/activities/dashboard/ActivityDashboard.svelte";
</script>

<main>
  <NavBar/>
  <div class="container-sm">
    <Router>
      <Route path="/" component={HomePage} />
      <Route path="/activities" component={ActivityDashboard} />
      <Route path="/createActivity" component={ActivityForm} />
    </Router>
  </div>
</main>
